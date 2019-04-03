namespace Note.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class  |
                           System.AttributeTargets.Struct,
                           AllowMultiple = true)]
    internal class Author : System.Attribute
    {
        private readonly string name;

        /// <summary>
        /// Specifies an author. Author's can only be assigned
        /// for classes, structs, and methods.
        /// </summary>
        /// <param name="name">The name of the author</param>
        public Author(string name)
        {
            this.name = name;
            Version = 1.0;
        }

        public double Version { get; set; }
    }
}
