//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleFace
{
    
    internal partial class Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resources.manager == null))
                {
                    Resources.manager = new System.Resources.ResourceManager("SimpleFace.Resources", typeof(Resources).Assembly);
                }
                return Resources.manager;
            }
        }
        internal static Microsoft.SPOT.Font GetFont(Resources.FontResources id)
        {
            return ((Microsoft.SPOT.Font)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        internal static byte[] GetBytes(Resources.BinaryResources id)
        {
            return ((byte[])(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            Candara48NPSSp = -12315,
            BookAntiquaNumbers = 10697,
            small = 13070,
            NinaB = 18060,
        }
        [System.SerializableAttribute()]
        internal enum BinaryResources : short
        {
            hat = 17847,
        }
    }
}
