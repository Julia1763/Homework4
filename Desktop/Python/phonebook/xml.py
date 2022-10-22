from UI import name_view
from UI import surname_view
from UI import phone_view


def create(device=1):
    xml = '<xml>\n'
    xml += '    <name units = "c">{}</name>\n'\
        .format(name_view(device))
    xml += '    <surname units = "m/s">{}</surname>\n'\
        .format(surname_view(device))
    xml += '    <phone units = "mmHg">{}</pressure>\n'\
        .format(phone_view(device))
    xml += '</xml>'

    with open('data.xml', 'w') as page:
        page.write(xml)

    return xml


def new_create(data, device = 1):
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

    return data