
# SampleNameChanger
Automatically renames your virtual instrument samples.

## REMEMBER ALWAYS BACKUP YOUR SAMPLES BEFORE USING THIS PROGRAM
## Getting Started
To start the program run WPFUI.exe.

Select your chosen samples with "Select Files"

Specify amounts of round robins within your samples. 0 means no round robins will taken to account.

With filename you can rename your selected samples to wanted name. However don't add any dynamic markings, round robins or note pitches they are done automatically

Specify starting note and ending note of your samples. If dynamic are not defined sample won't be named with dynamic markings.

Example how sample is named.

Sample => BaseOfFilename(NumberOfSample) pp C0 1RR
## Warning
Your samples must be in specific order allowing program to work.

Order which samples must be in the folder.


Sample01(Lowest dynamic, starting note, RR1)

Sample02(Lowest dynamic, starting note, RR2)

Sample03(Lowest dynamic, next note, RR1)

Sample04(Lowest dynamic, next note, RR2)

Sample05(Lowest dynamic, ending note, RR1)

Sample06(Lowest dynamic, ending note, RR2)

Sample07(second Lowest dynamic, starting note, RR1)

etc...


## Installing

To install this program go to and download /ReleaseVersions/[version number].zip file and extract it to chosen folder.


## Built With
Caliburn Micro
## License
This project is licensed under the MIT License - see the LICENSE.md file for details

## Acknowledgments
Thanks to contributors of caliburn micro.
