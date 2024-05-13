namespace ExampleProject;

/// <summary>
/// Represents an example class we can use to build documentation with docfx
/// </summary>
/// <remarks>
/// This class contains two properties, a constructor, and a method.
/// </remarks>
public class ExampleClass
{
    /// <summary>
    /// Gets or Sets the value of <see cref="Foo"/>
    /// </summary>
    public int Foo { get; set; }

    /// <summary>
    /// Gets or Sets the value of <see cref="Bar"/>.
    /// </summary>
    public string? Bar { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExampleClass"/> class.
    /// </summary>
    public ExampleClass() { }

    /// <summary>
    /// Returns a value that indicates whether the <see cref="Bar"/> property is <see langword="null"/>.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the <see cref="Bar"/> property of this instance of the <see cref="ExampleClass"/>
    /// class is <see langword="null"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsBarNull() => string.IsNullOrEmpty(Bar);
}