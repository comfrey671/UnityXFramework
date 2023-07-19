def space_str(layer):
	lua_str = ""
	for i in range(0, layer):
		lua_str += '	'
	return lua_str

def dic_to_lua_str(data, layer=0):
	d_type = type(data)
	if d_type is tuple:
		if 'str' == data[0]:
			return "'" +  data[1] + "'"
		elif 'num' == data[0]:
			return str(data[1])
		elif 'lua' == data[0]:
			return '{}' if '' == data[1] else str(data[1])
	elif d_type is list:
		lua_str = "{"
		lua_str += space_str(layer+1)
		for i in range(0, len(data)):
			lua_str += dic_to_lua_str(data[i], layer+1)
			if i < len(data)-1:
				lua_str += ','
		lua_str += '\n'
		lua_str += space_str(layer)
		lua_str += '}'
		return lua_str
	elif d_type is dict:
		lua_str = ''
		lua_str += "\n"
		lua_str += space_str(layer)
		lua_str += "{\n"
		data_len = len(data)
		data_count = 0
		for k, v in data.items():
			data_count += 1
			lua_str += space_str(layer+1)
			if type(k) is int:
				lua_str += '[' + str(k) + ']'
			else:
				lua_str += k
			lua_str += ' = '
			try:
				lua_str += dic_to_lua_str(v, layer + 1)
				if data_count < data_len:
					lua_str += ',\n'

			except Exception as e:
				print('error in ', k, v)
				raise
		lua_str += '\n'
		lua_str += space_str(layer)
		lua_str += '}'
		return lua_str
	else:
		print(d_type, 'is error')
		return None
