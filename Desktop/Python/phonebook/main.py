import UI
import xml as xg
import data_provider as dp

data = xg.read('data.xml')
UI.menu(data)
xg.new_create(dp.data_collection())