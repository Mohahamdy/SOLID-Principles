////Problems: We use unnecessary functions in our Classes
//public interface IMediaPlayer
//{
//    void PlayAudio();
//    void PlayVideo();
//    void DisplaySubtitles();
//    void LoadMedia(string filePath);
//}
//public class AudioPlayer : IMediaPlayer
//{
//    public void PlayAudio(){}
//    public void PlayVideo()
//    {
//        throw new NotImplementedException("Audio players cannot playvideos.");
//    }
//    public void DisplaySubtitles()
//    {
//        throw new NotImplementedException("Audio players cannot displaysubtitles.");
//    }
//    public void LoadMedia(string filePath) { }
//}
//public class VideoPlayer : IMediaPlayer
//{
//    public void PlayAudio()
//    {
//        throw new NotImplementedException("Video players cannot play audio without video.");
//    }
//    public void PlayVideo() { }
//    public void DisplaySubtitles() { }
//    public void LoadMedia(string filePath) { }
//}


/*Solution*/
//So we need to make interfaces as each one makes a specefic task
public interface IPlayAudio
{
    void PlayAudio();
}
public interface IPlayVideo
{
    void PlayVideo();
}
public interface IDisplaySubtitle
{
    void DisplaySubtitle();
}
public interface ILoadMedia
{
    void LoadMedia(string filePath);
}

//Then use these Interfaces in our classes as we need
public class AudioPlayer: IPlayAudio, ILoadMedia
{
    public void PlayAudio()
    {
        //Implement Code
    }

    public void LoadMedia(string filePath)
    {
        //Implement Code
    }
}

public class VideoPlayer : IPlayVideo, IDisplaySubtitle, ILoadMedia
{
    public void PlayVideo()
    {
        //Implement Code
    }

    public void DisplaySubtitle()
    {
        //Implement Code
    }

    public void LoadMedia(string filePath)
    {
        //Implement Code
    }

}
