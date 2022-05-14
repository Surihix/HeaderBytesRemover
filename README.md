# HeaderBytesRemover

Ever came across a file with weird Header data after which there is another header which is the actual one that the file uses ? 

This app can remove such header bytes or the bytes at the start of a file by letting you specify the exact byte position from where you want to copy the bytes from the file into a new file. 

This is quite helpful when you have such header bytes that can prevent the file from being accessed properly due to the presence of the header and so removing that can inturn make the file properly accessible.
<br>
<br>
## Instructions [applies to current v1.2]
Place the file that want the bytes removed, next to the app and then run the app. then enter the filename with the extension on the console.
<br>For Example:
<br>```myfile.sok```


<br>Press enter and then type the byte number from where you want the data of the file to be copied from, on the console. the byte number has to be in ```int```.
<br>For Example:
<br>```16```


<br>Press Enter once again and type the name of the output file that you want to give along with the extension on the console.
<br>For Example:
<br>```myfile.wav```

<br>Press Enter and the app will then create a new file with the header bytes removed along with the extension and the filename that you specified on the console.

<br>
<br>
<br>
<br>

## Instructions [applies to older v1.0 and v1.1] 
Place the file that you want the bytes removed, next to the app and type the filename of the file with the extension in the infile_name.txt file.
<br>For Example:
<br>```myfile.sok```


<br>Type the byte number from where you want the data of the file to be copied from. 
the byte number has to be in ```int``` and entered in the "byte_position.txt" file.
<br>For Example:
<br>```16```


<br>Type the name of the output file that you want to give along with the extension in the outfile_name.txt file.
<br>For Example:
<br>```myfile.wav```

<br>Run the app and it will then create a new file with the header bytes removed along with the extension and the filename specified in the outfile_name.txt.
