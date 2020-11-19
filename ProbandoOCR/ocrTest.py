# -*- coding: utf-8 -*-
"""
Created on Mon Oct 19 20:55:03 2020

@author: user
"""

import cv2
import pytesseract

pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files\Tesseract-OCR\tesseract'

image = cv2.imread('imgBN,jpg')

text = pytesseract.image_to_string(image,lang='spa')
print('Texto:',text)

cv2.inshow('Image',image)
cv2.waitKey(0)
cv2.destroyAllWindows()