/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */
namespace Paint.Parser
{
    public abstract class Value
    {
        public uint Children = 1; // TODO: make use of this variable
        public abstract JSONMemberType getType();
        public virtual JObject getObject()
        {
            return null;
        }

        public virtual JArray getArray()
        {
            return null;
        }

        public virtual JString getString()
        {
            return null;
        }

        public virtual JNumber getNumber()
        {
            return null;
        }

        public virtual JNull getNull()
        {
            return null;
        }

        public virtual JTrue getTrue()
        {
            return null;
        }

        public virtual JFalse getFalse()
        {
            return null;
        }

        public abstract Value ConsoleColorization(int indentation);
        public abstract string Indent(uint indentation = 0);
    }

    public enum JSONMemberType
    {
        String,
        Array,
        Number,
        Object,
        Null,
        False,
        True
    }
}