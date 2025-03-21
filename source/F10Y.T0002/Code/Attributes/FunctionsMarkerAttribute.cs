using System;

using F10Y.T0000;


namespace F10Y.T0002
{
    /// <summary>
    /// Attribute indicating an interface contains function instances. (i.e. default implementation methods on an interface).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying function interfaces and building a catalogue of functions.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Functions are always default implementation methods on an interface.
        AllowMultiple = false, // No.
        Inherited = false // Make the inheritor also use the marker.
    )]
    [MarkerAttributeMarker]
    public class FunctionsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a functionality interface.
        /// This is useful for marking interfaces that end up canonical functionality code file locations, but are not functionality interfaces.
        /// </summary>
        public bool Is_Functionality { get; }


        public FunctionsMarkerAttribute(
            bool is_Functionality = true)
        {
            this.Is_Functionality = is_Functionality;
        }
    }
}
