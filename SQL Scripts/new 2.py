line = input()

while True:
	l = line.split('\t')
	
	print("INSERT INTO Medications")
	print("VALUES ('" + l[0] + "', '" + l[1] + "')")
	print("")

	try:
		line = input()
	except:
		break