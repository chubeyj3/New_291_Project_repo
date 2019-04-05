from faker import Faker 
fake = Faker()
import urllib
import pyodbc
import json
import sqlite3
conn_str = (
    r'Driver={SQL Server};'
    r'Server=.\SQLEXPRESS;'
    r'Database=291Project;'
    r'Trusted_Connection=yes;'
    )
cnxn = pyodbc.connect(conn_str)
cur = cnxn.cursor()
cur2 = cnxn.cursor()

## Patients

newvals = []
rows = cur.execute('SELECT * FROM Patient')
for row in rows:
    update = {
    "id" : row.PID,
    "first" : fake.first_name(),
    "last" : fake.last_name(),
    "country" : fake.country(),
    "state" : fake.state(),
   "city" : fake.city(),
    "street" : fake.random_number(),
    "postal": fake.postalcode()}

    for k, v in update.items():

        try:
            if(len(v) >= 23):
                update[k] = v[0:24]
        except:
            continue

    newvals.append(update)

for i in range(len(newvals)):
    value = newvals[i]
    print(value)
    thisRow = cur.execute("update Patient set FirstName=?, LastName=?, Country=?, State=?, City=?, StreetAddress=?, PostalCode=? where PID=?", value["first"], value["last"], value["country"], value["state"], value["city"], value["street"], value["postal"], value["id"])


## Adding some doctors
cur.execute("alter table Doctor add FirstName varchar(25), LastName varchar(25)")

newvals = []
rows = cur.execute('SELECT * FROM Doctor')
for row in rows:
    update = {
    "id" : row.DoctorID,
    "first" : fake.first_name(),
    "last" : fake.last_name()
    }

    for k, v in update.items():

        try:
            if(len(v) >= 23):
                update[k] = v[0:24]
        except:
            continue

    newvals.append(update)

for i in range(len(newvals)):
    value = newvals[i]
    print(value)
    thisRow = cur.execute("update Doctor set FirstName=?, LastName=? where DoctorID=?", value["first"], value["last"], value["id"])

cnxn.commit()
