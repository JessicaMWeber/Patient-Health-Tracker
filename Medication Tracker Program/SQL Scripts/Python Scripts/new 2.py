line = input()

while True:
	l = line.split('\t')
	
	print("INSERT INTO Medications VALUES ('" + l[0] + "', '" + l[1] + "')")

	try:
		line = input()
	except:
		break