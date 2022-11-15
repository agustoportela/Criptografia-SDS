from cryptography.fernet import Fernet

#Escribimos (creamos) la clave (que va a cifrar) - Se la escribe en el archivo key.key
def write_key():
    key = Fernet.generate_key()
    with open("key.key", "wb") as key_file:
        key_file.write(key)

#Cargamos la clave (se devuelve/retorna la clave) a traves del archivo key.key que contiene la clave
def load_key():
    return open("key.key", "rb").read()

#Funcion que permite encriptar el mensaje. Recibe por parametro el archivo a encriptar y la clave
def encrypt_file(filename, key):
    f = Fernet(key)

    with open(filename, "rb") as file:              #Abre el archivo y recupera los datos del mismo
        file_data = file.read()
    
    encrypted_data = f.encrypt(file_data)           #Me permite cifrar datos

    with open(filename, "wb") as file:              #Abro y escribo en el archivo los datos cifrados
        file.write(encrypted_data)

#Funcion que permite desencriptar el mensaje. Recibe por parametro el archivo encriptado y la clave
def decrypt_file(filename, key):
    f = Fernet(key)

    with open(filename, "rb") as file:              #Leo los datos cifrados
        encrypted_data = file.read()
    
    decrypted_data = f.decrypt(encrypted_data)      #Me permite desifrar datos

    with open(filename, "wb") as file:              #Abro y escribo en el archivo los datos decifrados
         file.write(decrypted_data)

key = load_key()                                    #Me permite cargar la clave en la variable "Key"

#Con esta funcion podemos leer un archivo:
def readFile(file):
    stream = open(file,"rt", encoding="utf-8")      #Nos lee el archivo en formato utf-8
    print(stream.read())

#Con esta funcion podemos agregar una texto en un archivo:
def writeFile(line,file):
    with open(file, 'a') as file:
        file.write("\n" + line)                     #Va escribiendo por lineas












#message = input("Enter you secret ms: ").encode()

#write_key()

#key = load_key()

#f = Fernet(key)

#encrypted_message = f.encrypt(message)
#print(encrypted_message)

#decrypted_message = f.decrypt(encrypted_message)
#print(decrypted_message)