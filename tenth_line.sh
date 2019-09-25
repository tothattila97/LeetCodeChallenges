# Read from the file file.txt and output the tenth line to stdout.
#!/bin/bash

#sed -n "10 p" "file.txt"

#sed '10!d' "file.txt"

awk 'NR==10' "file.txt"
