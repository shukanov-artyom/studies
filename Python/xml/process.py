import sys
import os.path
import xml.etree.ElementTree as etree

ns = '{http://schemas.microsoft.com/exchange/services/2006/types}'

def processAttach(att):
    isPic = att.findall('IsContactPhoto')
    if isPic is None:
        isPicElement = etree.Element(ns + 'IsContactPhoto', 'false')
        att.append(isPicElement)

def proc(filepath):
    tree = etree.parse(filepath)
    root = tree.getroot()
    attaches = root.findall(ns + 'Attachments')
    print(attaches)
    for attach in attaches:
        fileAttaches = attach.findall(ns + 'FileAttachment')
        for fileAttach in fileAttaches:
            processAttach(fileAttach)
proc('message_1.xml')

'''for line in open('files.txt'):
    line = line.rstrip('\n')
    if os.path.isfile(line):
        proc(line)'''


