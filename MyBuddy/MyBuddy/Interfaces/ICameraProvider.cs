using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuddy
{
    public interface ICameraProvider
    {
        Task<CameraResult> TakePictureAsync();
    }
}