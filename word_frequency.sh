# Read from the file words.txt and output the word frequency list to stdout.
#!/bin/bash

#cat words.txt | awk '{for(i=1;i<=NF;++i){D[$i]++}}END{for(k in D)print k, D[k]}' | sort -rn -k2

#cat words.txt | tr -s ' ' '\n' |sort|uniq -c|sort -nr|awk '{print $2, $1}'

#Parse the file with tr command which uses –s option for search and replace any string from a text.
#To select only non-empty lines grep -v "^$" (-v means invert match).
#Then we can sort the output (if we use -r then revert the sort).
#Counts the output with uniq -c.
#Finally pipe to awk which swap the columns order.

tr -s ' ' '\n' < words.txt |sort|uniq -c|sort -r|awk '{print $2, $1}'

#sed -r 's/\s+/\n/g' words.txt | grep -v "^$" | sort | uniq -c | sort -r | awk '{print $2" "$1}'
