using src.Core.Entity;

namespace src.Service.Factory;

public class MediaFactory
{

    public static Media CreateBook(string filePath, string filename, TimeSpan duration, string fileType, int id)
    {
        string typeName = $"src.Core.Entity.${fileType}Media";

        typeName = typeName ?? "";


        if (typeName == "") throw new Exception($"Media class for this type not found {fileType}.");

        Type type = Type.GetType(typeName);

        if (type != null && typeof(Media).IsAssignableFrom(type))
        {
            return Activator.CreateInstance(type, new object[] { filePath, filename, duration, id }) as Media;
        }

        throw new Exception($"Media Type {fileType} Not found.");
    }


}
