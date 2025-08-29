using System;

using F10Y.T0000;


namespace F10Y.T0002
{
    /// <summary>
    /// Attribute indicating a method is a function instance.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying function instances and building a catalogue of functions.
    /// <para>
    /// This marker is useful for marking specific methods as functions, but the <see cref="FunctionSetMarkerAttribute"/> and <see cref="FunctionsMarkerAttribute"/> can be used to mark all methods within an interface as functions
    /// (and using these markers is preferable).
    /// </para>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method, // Functions are always methods (not properties or delegates).
        AllowMultiple = false, // No.
        Inherited = false // Methods are not inherited, maybe overloaded? So probably not needed. But for completeness, make explicitly false.
    )]
    [MarkerAttributeMarker]
    public class FunctionMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a method is *not* a function instance.
        /// This is useful for marking methods that end up canonical function code locations, but are not function instances.
        /// </summary>
        public bool Is_Function { get; }


        public FunctionMarkerAttribute(
            bool is_Function = true)
        {
            this.Is_Function = is_Function;
        }
    }
}
