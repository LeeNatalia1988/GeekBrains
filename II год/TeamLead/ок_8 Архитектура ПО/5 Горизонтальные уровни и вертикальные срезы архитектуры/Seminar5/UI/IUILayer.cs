using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.UI
{
    internal interface IUILayer
    {
        abstract void OpenProject(String FileName);
        abstract void ShowProjectSettings();
        abstract void SaveProject();
        abstract void PrintAllModels();
        abstract void PrintAllTextures();
        abstract void RenderAll();
        abstract void RenderModel(int i);
        abstract void AddTexture();
        abstract void AddModel();
        abstract void RemoveTexture();
        abstract void RemoveModel();

        

    }
}
