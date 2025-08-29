using System;

using F10Y.T0000;


namespace F10Y.T0002
{
    /// <summary>
    /// Attribute indicating an interface is a function set (contains function instances). (i.e. default implementation methods on an interface).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying function sets and building a catalogue of functions.
    /// <para>
    /// Both this marker attribute and <see cref="FunctionsMarkerAttribute"/> can be used to mark all methods in an interface as functions,
    /// but the <see cref="FunctionMarkerAttribute"/> can be used to mark any method as a function instance.
    /// (Using these whole-set marker attributes is preferable.)
    /// </para>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Function are always default implementation methods on an interface, so function sets are always interfaces.
        AllowMultiple = false, // No.
        Inherited = false // Make the inheritor explicitly also use the marker.
    )]
    [MarkerAttributeMarker]
    public class FunctionSetMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a function set.
        /// This is useful for marking interface types that end up canonical function set code file locations, but are not function set interfaces.
        /// </summary>
        public bool Is_FunctionSet { get; }


        public FunctionSetMarkerAttribute(
            bool is_FunctionSet = true)
        {
            this.Is_FunctionSet = is_FunctionSet;
        }
    }
}
