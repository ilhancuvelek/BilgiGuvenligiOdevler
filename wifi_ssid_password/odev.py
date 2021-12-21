import subprocess
import os

data = subprocess.check_output(['netsh', 'wlan', 'show', 'profiles']).decode('utf-8',errors="ignore").split('\n')

profiles=[]

for i in data:
    if "All User Profile" in i:
        i=i.split(":")
        i=i[1]

        i=i[1:-1]

        profiles.append(i)

path=os.getcwd()+"\\readme.txt";    

if os.path.exists(path):
    os.remove(path)
f=open(path, 'a')

f.write("{:<30}| {:<}".format("wifi name","password")+"\n")
f.write("------------------------------------------------------"+"\n")

for i in profiles:
    try:
        results=subprocess.check_output(['netsh', 'wlan', 'show', 'profile', i, 'key=clear']).decode('utf-8',errors="ignore").split(
        '\n')
        results=[b.split(":")[1][1:-1] for b in results if "Key Content" in b]
        try:
            f.write("{:<30}| {:<}".format(i,results[0])+"\n")   
        except IndexError:
            f.write("{:<30}| {:<}".format(i,"")+"\n")
    except subprocess.CalledProcessError:
          print("encoding error occured")
