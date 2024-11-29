using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Rhino.Core
{
    public static partial class Query
    {
        public static bool SaveAs(this Grasshopper.Kernel.Data.IGH_Structure gH_Structure)
        {
            if (gH_Structure == null)
            {
                return false;
            }

            List<ISerializableObject> jSAMObjects = SerializableObjects<ISerializableObject>(gH_Structure);
            if (jSAMObjects == null || jSAMObjects.Count == 0)
            {
                return false;
            }

            string path = null;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                path = saveFileDialog.FileName;
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            System.IO.FileInfo fileInfo = DiGi.Core.Convert.ToSystem_FileInfo(jSAMObjects, path);

            return fileInfo != null && fileInfo.Exists;
        }
    }
}
