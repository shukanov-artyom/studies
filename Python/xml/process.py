import sys
import os.path
import xml.etree.ElementTree as etree

'''
Пока ещё неудачный опыт работы с XML файлами с простраснтвами имён с помощью библиотеки etree
Неудача состоит в том, что после редактирования и перезаписи протсранство имён добавляется перед каждым тегом,
как этого избежать непонятно
'''

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
    tree.write(filepath)

proc('message_1.xml')

'''for line in open('files.txt'):
    line = line.rstrip('\n')
    if os.path.isfile(line):
        proc(line)'''


