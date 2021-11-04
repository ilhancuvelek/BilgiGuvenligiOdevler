from selenium import webdriver
import time
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.alert import Alert
import pytesseract
from PIL import Image

pytesseract.pytesseract.tesseract_cmd = 'C:\\Program Files\\Tesseract-OCR\\tesseract.exe'


# a=pytesseract.image_to_string(Image.open('img\captcha.png'))

browser=webdriver.Chrome("C:\\Users\\İlhan\\Documents\\py\\chromedriver.exe")
browser.get("file:///C:/Users/%C4%B0lhan/Documents/py/form.html")

adInput=browser.find_element_by_xpath("/html/body/div/div[1]/div[1]/div/input")
telInput=browser.find_element_by_xpath("/html/body/div/div[1]/div[2]/div/input")
adresInput=browser.find_element_by_xpath("/html/body/div/div[1]/div[3]/div/input")
captchaInput=browser.find_element_by_xpath("/html/body/div/div[2]/div[2]/p/input")

img=browser.find_element_by_id("captchaa").get_attribute("src")

# file:///C:/Users/%C4%B0lhan/Documents/py/img/captcha.png
a=pytesseract.image_to_string(Image.open(img[41:]))


adInput.send_keys("İlhan Cüvelek") 
telInput.send_keys("01234654")
adresInput.send_keys("fırat üniverstesi")
captchaInput.send_keys(a)

button=browser.find_element_by_tag_name("button")
time.sleep(2)
button.click()

alert=Alert(browser)
time.sleep(2)

alert.accept()
time.sleep(2)
alert.accept()



