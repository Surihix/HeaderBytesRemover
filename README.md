# HeaderBytesRemover
This app can remove the header bytes or the bytes at the start of a file that can prevent certain files from being accessed properly.

Place the file next to the app and type the filename of the file with the extension in the infile_name.txt file.
<br>For Example:
<br>```myfile.sok```


<br>Type the byte number from where they want the actual file data of the file specified in the converted output file. 
the byte number has to be in ```int``` and entered in the "byte_position.txt" file.
<br>For Example:
<br>```16```


<br>Type the name of the output file that you want to give along with the extension in the outfile_name.txt file.
<br>For Example:
<br>```myfile.wav```

<br>Run the app and it will then create a new file with the header bytes removed along with the extension and the filename specified in the outfile_name.txt.
