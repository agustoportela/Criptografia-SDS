import main                                             #Importo el archivo main

filename = "file.txt"                                   #Llamo al archivo de texto
opcion = 0                                              #Opcion q sirve para el menu   
encriptado = False                                      #Bandera para chekear si esta encriptado o no



while opcion != 5:                                      #Menu hecho para seleccionar la opcion
    print("\n--------Selecciona una opcion del MENU --------")
    print("1. Leer Archivo\n2. Agregar Texto al Archivo"
            "\n3. Encriptar\n4. Desencriptar\n5. Salir")
    
    opcion = int(input("Ingesa una opcion: "))

    if opcion == 1: 
        print("\nEl contenido del archivo es: ")
        main.readFile(filename)

    elif opcion == 2:
        line = input("Introduce el texto a agregar: ")
        main.writeFile(line,filename)
        print("\n" + "Ok! Contenido agregado con exito.")

    elif opcion == 3:
        main.encrypt_file(filename, main.key)
        print("\nEl archivo ha sido ENCRIPTADO con exito")
        encriptado = True

    elif opcion == 4:
        if encriptado == True:
            main.decrypt_file(filename, main.key)
            print("\nEl archivo ha sido DESENCRIPTADO con exito")
            encriptado = False
        else:
            print("\n El archivo que usted desea desencriptar, no se encuentra encriptado previamente.")
    
    elif opcion == 5:
        exit
    
    else:
        print("\n¡La opcion seleccionada es Incorrecta!")
