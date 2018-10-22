'''
http://cueh.coventry.ac.uk/~james/ALL/sem1/week3/tunnels.html

HELLO WORLD THE RETURN (coming to cinemas 01.04.19)

> USER GOTTA IMPUT MAC ADDRESS
> SEARCH MAC ADDRESS
> FIND VENDOR
> -
> P R O F I T 
'''
import string                                   #because i need the alphabet and im lazy to type it all out
import requests                                 #to actually request the pages
from bs4 import BeautifulSoup                   #makes web pages into tasty shit a toddler can play with
                                                #   urllib is the enabler adult and BeautifulSoup isnt even its child

alphabet = list(string.ascii_lowercase)
numbers  = ['0','1','2','3','4','5','6','7','8','9']

mac_temp = input("Input ur MAC addwess plz: ")          #asks the user nicely for their mac addwess
user_mac = ''

for i in range(len(mac_temp)):                          #this messy shit takes out all non-alphanumeric characters
    #print(i,mac_temp[i])                               #because urls wont work with them in
    if mac_temp[i] in alphabet:
        user_mac += mac_temp[i].upper()
    elif mac_temp[i] in numbers:
        user_mac += mac_temp[i]

mac_page = "https://api.macvendors.com/" + user_mac     #https://api.macvendors.com is a beautiful api

coolpage = requests.get(mac_page)                       #requests the page
soupy_page = BeautifulSoup(coolpage.content,'lxml')     #the formats it so its readible
vendor = soupy_page.get_text()                          #gets all the text from the page,
                                                        #   text is like the chocolate in a nutella bar

print('==============================')
print('Your MAC address is',user_mac)
print('Your vendor is',vendor)
print('==============================')


