# HeaderBytesRemover
This app can remove the header bytes or the bytes at the start that can prevent certain files from being accessed properly .


Place the file next to the app and type the filename of the file with the extension in the infile_name.txt file.
<br>Example:
<br>myfile.sok


Type the byte number from where they want the actual file data of the file specified in the converted output file. the byte number has to be in int and 
entered in a "byte_position.txt" file which is once again placed next to
<br>Example:
<br>16


Type the name of the output file that you want to give along with the extension in the outfile_name.txt file.
<br>Example:
<br>myfile.wav


Run the app and it will then create a new file with the header bytes removed along with the extension and the filename specified in the outfile_name.txt.
