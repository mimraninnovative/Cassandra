# Cassandra in dotnet core using docker step by step guaid
1.docker pull cassandra
     docker images

2 .**Run Container using Image**
   docker run -p 7000:7000 -p 7001:7001 -p 7199:7199 -p 9042:9042 -p 9160:9160 --name cassandra -d cassandra:latest
   Docker -ps
3.  use (container_id) in below  
     exec -it  6f9c6381c62e bash
4.**Create & describe Keyspace**
     create keyspace techframer with replication    ={'class':'SimpleStrategy','replication_factor':1};
     desc keyspaces

5.**Create Table**
    use techframer;
    CREATE TABLE student (student_id int PRIMARY KEY,student_name text,student_city text ,student_fees varint, student_phone varint);
    select * from student
     insert into student (student_id,student_fees,student_name)values(1,5000,'Ajeet');
  select * from student;
  
  
![image](https://github.com/mimraninnovative/Cassandra/assets/49446457/a6e3f11a-0031-4356-9951-26eb04c0dc36)
