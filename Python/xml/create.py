'''
Создаём XML-файл, записываем туда данные
'''

import sys
import os.path
import xml.etree.ElementTree as etree

root = etree.Element("root")                                # создаём корневой элемент
doc = etree.SubElement(root, "doc")                         # подэлемент корня

fl1 = etree.SubElement(doc, "field1", name="blah")          # тэг
fl1.text = "some value1"
fl2 = etree.SubElement(doc, "field2", name="asdfasd")       # другой тэг
fl2.text = "some value2"

tree = etree.ElementTree(root)                              # объект дерева
tree.write("out.xml")                                       # сохраняем
