namespace Utilities.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class  |
                           System.AttributeTargets.Struct,
                           AllowMultiple = true)]
    internal class Author : System.Attribute
    {
        private readonly string name;
        public double version;

        /// <summary>
        /// Specifies an author. Author's can only be assigned
        /// for classes, structs, and methods.
        /// </summary>
        /// <param name="name">The name of the author</param>
        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class  |
                           System.AttributeTargets.Struct, 
                           AllowMultiple = true)]
    internal class CoAuthor : System.Attribute
    {
        private readonly string name;
        public double version;    

        /// <summary>
        /// Specifies an author. Author's can only be assigned
        /// for classes, structs, and methods. A CoAuthor cannot specify
        /// a version
        /// </summary>
        /// <param name="name">The name of the author</param>
        public CoAuthor(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }
}
