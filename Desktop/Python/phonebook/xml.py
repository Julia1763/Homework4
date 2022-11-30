from UI import *
import xml
from xml import etree


def read(file):
    data = []
    with open(file, newline='') as xmlfile:
        data_reader = etree.parse(filename)
        for row in data_reader:
            data.append(row[0], row[1], row[2], row[3])
    return data



def write_data(file, device = 1):
    n, s, p = data
    xml = '<xml>\n'
    xml += '    <name units = "f">{}</name>\n'\
        .format(n)
    xml += '    <surname units = "m/s">{}</surname>\n'\
        .format(s)
    xml += '    <phone units = "mmHg">{}</phone>\n'\
        .format(p)
    xml += '</xml>'

    with open('new_data.xml', 'w') as page:
        page.write(xml)
    return file