using AForge.Video.DirectShow;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.CvEnum;



namespace ProcesamientoImagenes
{    
    
    public class ImageManager
    {
        private Bitmap _image;
        private VideoCapture _video;
        private double _duration;
        private double _frames;
        private int _currentFrame;

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

        public VideoCapture getVideo()
        {
            return this._video;
        }

        public void setVideo(VideoCapture video)
        {
            this._video = video;
            this.setDuration(video.GetCaptureProperty(CapProp.FrameCount));
            this.setFrames(video.GetCaptureProperty(CapProp.PosFrames));
        }

        public double getDuration()
        {
            return this._duration;
        }

        private void setDuration(double duration)
        {
            this._duration = duration;
        }

        public double getFrames()
        {
            return this._frames;
        }

        public void setFrames(double frames)
        {
            this._frames = frames;
        }

        public int getCurrentFrame()
        {
            return this._currentFrame;
        }

        public void setCurrentFrame(int currentFrame)
        {
            this._currentFrame = currentFrame;
        }
    }
}
