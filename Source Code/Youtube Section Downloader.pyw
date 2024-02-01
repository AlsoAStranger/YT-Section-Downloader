import os
from gooey import Gooey, GooeyParser


@Gooey(program_name="Youtube Section Downloader",
       program_description="A yt-dlp GUI focused on trimming Youtube Videos using timestamps",
       advanced=True,
       auto_start=True,
       default_size=(650, 720),
       required_cols=1,
       optional_cols=3,
       monospace_display=True,
       show_stop_warning=False,
       show_restart_button=False,
       header_height=60,
       clear_before_run=True,
       return_to_config=True,
       image_dir='C:/Users/matt/Desktop/Reorganize/Scripts/VisualElements',
       menu=[{
        'name': 'File',
        'items': [{
                'type': 'AboutDialog',
                'menuTitle': 'About',
                'name': 'Youtube Section Downloader',
                'description': 'A yt-dlp GUI focused on trimming Youtube Videos using timestamps.\n\nMade by: AlsoAStranger\nLicense: Unlicense\nIcons by Freepik from Flaticon',
                'version': '2.0',
                'website': 'https://github.com/AlsoAStranger/YT-Section-Downloader',
            }],
    }],
)
def main():
    parser = GooeyParser()

    parser.add_argument("ytlink", metavar="YouTube Link")

    optional_group = parser.add_argument_group("Optional Settings")

    optional_group.add_argument("--startTS", help="HH:MM:SS | MM:SS", metavar="Beginning Timestamp")
    optional_group.add_argument("--endTS", help="HH:MM:SS | MM:SS", metavar="Ending Timestamp")
    optional_group.add_argument("--filename", metavar="Filename", help="Name the output file")
    optional_group.add_argument("--audioCHK", action="store_true", metavar="Audio Only?")

    resolution_group = optional_group.add_mutually_exclusive_group()
    resolution_group.add_argument("--best", action="store_true", metavar="Best")
    resolution_group.add_argument("--r1080p", action="store_true", metavar="1080p")
    resolution_group.add_argument("--r720p", action="store_true", metavar="720p")
    resolution_group.add_argument("--noPremium", action="store_true", help="Select when downloading part of a video", metavar="No Premium")

    args = parser.parse_args()

    if (
        (args.startTS and not args.endTS and not args.filename)
        or (args.endTS and not args.startTS and not args.filename)
        or (args.startTS and args.endTS and not args.filename)
    ):
        print(
            "Error: If the Beginning Timestamp or Ending Timestamp is provided, the Filename must also be provided."
        )
        return

# If startTS, endTS, filename are filled, audioCHK is checked, and noPremium is not selected, print an error
    if args.startTS and args.endTS and args.filename and args.audioCHK and not args.noPremium:
        print(
        "Error: You must select the No Premium resolution to execute this command."
        )
        return

    downloads_folder = os.path.join(os.path.expanduser("~"), "Downloads")
    download_command = f'yt-dlp.exe -P home:{downloads_folder} --no-mtime'

    if args.r1080p:
        download_command += ' -f "bestvideo[height<=1080]+bestaudio/best[height<=1080]"'
    elif args.r720p:
        download_command += ' -f "bestvideo[height<=720]+bestaudio/best[height<=720]"'
    elif args.noPremium:
        download_command += " -f \"bv[vcodec^=avc][format_note!*=Premium]+ba[ext=m4a]/best[ext=mp4]/best\""
    else:
        download_command += ' -f "bestvideo+bestaudio/best"'

    download_command += f' "{args.ytlink}"'

    if args.audioCHK:
        download_command = download_command.replace("--recode mp4", "")
        download_command += " -x --audio-format mp3 --audio-quality 0"
    else:
        # If audioCHK is not checked, remove the audio download flags
        download_command = download_command.replace("--audio-format mp3 --audio-quality 0", "")

    if args.startTS and args.endTS:
        download_command += f' --download-sections "*{args.startTS}-{args.endTS}"'

        if args.filename:
            download_command += f' --output "{args.filename}"'
    elif args.filename:
        print("Error: Filename must be provided if startTS or endTS is provided.")
        return

    os.system(download_command)

if __name__ == "__main__":
    main()