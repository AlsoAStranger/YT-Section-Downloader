<div align="center">
 
 <img src=https://github.com/AlsoAStranger/YT-Section-Downloader/assets/137929175/4dd47c12-3521-4334-80e2-82bfd7c1d3c7 width="250" height="250">
</img>
 
# Youtube Section Downloader — Python Edition!
</div>

This is a new version of my [Youtube Section Downloader](https://github.com/AlsoAStranger/YT-Section-Downloader/tree/main) utility, with a new feature and a functional .EXE file, that runs on Python.  
Youtube Section Downloader is a [yt-dlp](https://github.com/yt-dlp/yt-dlp) Graphical User Interface (GUI) that helps the user download specific portions of YouTube videos using timestamps.  
However, it can be used to download entire videos as well.

All the user needs to do is provide the program with the link to the YouTube video.
The beginning and ending timestamps of the desired clip, together with the file name are optional.  
Users also have the option to download just the audio of the clip instead of both audio and video.
Lastly, there's an option to choose the desired resolution of the video. By default, the program will download the best resolution available.

<sub>*Note: The audio clip will be saved in MP3 format at its highest quality. The timestamps are accepted in the following formats: HH:MM:SS or MM:SS. The video will be downloaded to the user's "Downloads" folder.*</sub>

## Source code
I've uploaded the python script, which you can find in the "Source Code" folder.
Note that to run the script, [Gooey](https://github.com/chriskiehl/Gooey) is required.


[**Get the code here**](https://github.com/AlsoAStranger/YT-Section-Downloader/tree/python-edition/Source Code/Yotuube Section Downloader.pyw)

## Issues

#### **Issue #1: Beginning/Ending Frames not Rendering Correctly**
Sometimes, the saved video may display a still frame for the first few seconds before rendering the frames correctly. This could also happen in the last few seconds, although less likely.

This issue seems to be related to yt-dlp and/or ffmpeg, which take some time to process the video correctly. To ensure that the necessary frames are rendered correctly, it is highly suggested to consider adding 5-10 seconds more to the desired clip.  
*(For example: instead of downloading a video from 2:00 to 5:00, it may be better to download it from 1:50 to 5:10)*

This means that further video editing is required if the objective is to simply share a clip without unnecessary context  
*(For example, if someone wanted to share a joke, having unrelated parts of the video would ruin the clip)*.

However, this issue should not affect audio-only clips, as the audio is processed correctly from the beginning to the end. It's worth noting that when downloading a clip with video, the original audio will play under the still frames.

##  General Info

#### **Why did you make this utility?**

Yt-dlp is a command-line program.
Though there's GUI versions of both [yt-dlp](https://github.com/yt-dlp/yt-dlp) and [yt-dl](https://github.com/ytdl-org/youtube-dl), I have not seen a simple, easy to use software to clip and download a specific portion of a video using timestamps.

#### **Why should I want to use this utility?**

I found it to be incredibly useful to quickly extract a snippet from long-form videos. Whether they'd be hour long podcasts, Stream VODs, or even to get 30 seconds from a 20 minute video.

Downloading the whole video results in a waste of space and time, and the command-line can get tiring since it requires to write and edit the command each time.

#### **Why a Python edition?**
As much as I like having designed from scratch the Visual Basic version, it still needs a lot of work. There are issues I need to fix and can't be bothered to.
This edition not only uses a very common coding language, but new features can be implemented more easily and it has a working executable.

## Missing Features

- Possibility to select **video format**
- Possibility to select **audio quality manually**
- Possibility to select **audio format**
- Possibility to set **custom download location** *(the clip will be downloaded in the user's "Downloads" folder)*
- **Progress bar** *(There's a progress bar but it acts more like a loading icon)*
- **Thumbnail and Title preview** of the inputted link

## Requirements

 - [**yt-dlp**](https://github.com/yt-dlp/yt-dlp)
 - [**ffmpeg** and **ffprobe**](https://www.ffmpeg.org/)
 - [**Python**](https://www.python.org/)

 ***Important:** The code was made to work with yt-dlp and ffmpeg added to the [**PATH Environment Variable**](https://learn.microsoft.com/en-us/previous-versions/office/developer/sharepoint-2010/ee537574(v=office.14)).*
## Acknowledgements

 - [**Gooey**]([https://yd.3dyd.com/home/](https://github.com/chriskiehl/Gooey)), which I used to create the GUI.
 - [**ChatGPT**](https://openai.com/blog/chatgpt), which helped me troubleshoot and write the code.
 - [**VSCode**](https://code.visualstudio.com/), which I used to write and test the code.

## Preview
![preview](https://github.com/AlsoAStranger/YT-Section-Downloader/assets/137929175/561873cf-1e51-44b6-977b-a533726f5cf1)
