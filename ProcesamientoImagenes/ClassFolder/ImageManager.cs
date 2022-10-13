using System.Drawing;



namespace ProcesamientoImagenes
{    
    
    public class ImageManager
    {
        private Bitmap _image;

        private string _imageName;

        private bool _isPhoto;
        private ImageManager()
        {

        }

        private static ImageManager instance;

        public static ImageManager getInstance()
        {
            if (instance == null)
                instance = new ImageManager();
            return instance;
        }

        public Bitmap getImage()
        {
            return _image;
        }

        public void setImage(Bitmap image)
        {
            _image = image;
        }
        
        public string getImageName()
        {
            return _imageName;
        }

        public void setImageName(string imageName)
        {
            _imageName = imageName;
        }

        public void setIsPhoto(bool isPhoto)
        {
            this._isPhoto = isPhoto;
        }

        public bool isPhoto()
        {
            return this._isPhoto;
        }

    }
}
