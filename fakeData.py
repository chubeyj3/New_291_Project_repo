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
    "street" : fake.address(),
    "postal": fake.postalcode()}

    for k, v in update.items():

        try:
            if(len(v) >= 23):
                update[k] = v[0:24]
        except:
            continue

    newvals.append(update)

for i in range(len(newvals)-1):
    value = newvals[i]
    print(value)
    thisRow = cur.execute("update Patient set FirstName=?, LastName=?, Country=?, State=?, City=?, StreetAddress=?, PostalCode=? where PID=?", value["first"], value["last"], value["country"], value["state"], value["city"], value["street"], value["postal"], value["id"])

cnxn.commit()


## Adding some doctors
#cur.execute("alter table Doctor add FirstName varchar(25), LastName varchar(25)")

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

for i in range(len(newvals)-1):
    value = newvals[i]
    print(value)
    thisRow = cur.execute("update Doctor set FirstName=?, LastName=? where DoctorID=?", value["first"], value["last"], value["id"])

## Give departments real names 
cnxn.commit()

depts = [
    "Oncology",
    "Pediatrics",
    "Radiology",
    "Emergency",
    "Surgery",
    "Dermatology",
    "Neurology",
    "Gynecology",
    "Cardiology",
    "Allergy",
    "Endocrinology",
    "Rheumatology",
    "Neonatal",
    "Opthamology",
    "Psychiatry"
]
## Show department names
newvals = []
rows = cur.execute('SELECT * FROM Department')
i = 1
for row in rows:
    print(row)
    update = {
    "id" : row.DepartmentID,
    "name" : depts[i]
    }
    i += 1

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
    thisRow = cur.execute("update Department set Name=? where DepartmentID=?", value["name"], value["id"])

newvals = []
rows = cur.execute('SELECT * FROM PatientContactInfo')
i = 1
for row in rows:
    print(row)
    update = {
    "id" : row.PID,
    "email" : fake.email()
    }
    i += 1

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
    thisRow = cur.execute("update PatientContactInfo set Contact=? where PID=?", value["email"], value["id"])

cnxn.commit()

