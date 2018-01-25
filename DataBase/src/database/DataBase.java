package database;

import com.mongodb.MongoClient;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import java.util.Scanner;
import org.bson.Document;
import com.mongodb.Block;
import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class DataBase {
    
    private static Scanner in = new Scanner(System.in);
    private static DateFormat format = new SimpleDateFormat("dd.MM.yyyy");
    
    public static void main(String[] args) throws ParseException {
        try {
            MongoClient mongocl = new MongoClient("localhost", 27017);
            MongoDatabase mongodb = mongocl.getDatabase("DataBase");
            MongoCollection mongocol = mongodb.getCollection("Application");
            String date;
            int mode;
            
                /*                 Очистка и заполнение БД               */        
            //        mongocol.drop();
            //        for(int i = 0; i < 10; i++)
            //            fillDataBase(mongocol);
            
            applicationDataBase(mongocol);
            
            System.out.print("Введите дату для поиска (XX.XX.XXXX): ");
            date = in.next();
            format.parse(date);
            System.out.print("\n1. Точная;\n2. Раньше;\n3. Позже (включительно);\n4. Диапазон.\nВыберите режим поиска (1,2,3,4): ");
            mode = in.nextInt();
            
            queryFinder(mongocol, date, mode);
            
            System.in.read();
        } catch (IOException | java.text.ParseException ex) {
            Logger.getLogger(DataBase.class.getName()).log(Level.SEVERE, null, ex);
        } 
    }
    
    public static void queryFinder(MongoCollection mongocol, String date, int mode) {
        if(mode != 4)
            System.out.println("\nРезультаты поиска: ");

        Block<Document> block = new Block<Document>() {
            @Override
            public void apply(Document doc) {
                Object[] temp = doc.values().toArray();
                System.out.print(((int) temp[0] + 1) + ". Заявитель: " + temp[1] + "; Услуга: " + temp[2] + "; Дата: " + format.format(temp[3]) + "\n");
            }
        };
        
        try {
            switch(mode) {
                case 1:
                    if(mongocol.find(new Document("date", format.parse(date))).iterator().hasNext())
                        mongocol.find(new Document("date", format.parse(date))).forEach(block);
                    else
                        System.out.println("По данным критериям ничего не найдено");
                    break;
                case 2:
                    if(mongocol.find(new Document("date", new Document("$lt", format.parse(date)))).iterator().hasNext())
                        
                        mongocol.find(new Document("date", new Document("$lt", format.parse(date)))).forEach(block);
                    else
                        System.out.println("По данным критериям ничего не найдено");
                    break;
                case 3:
                    if(mongocol.find(new Document("date", new Document("$gte", format.parse(date)))).iterator().hasNext())
                        mongocol.find(new Document("date", new Document("$gte", format.parse(date)))).forEach(block);
                    else
                        System.out.println("По данным критериям ничего не найдено");
                    break;
                case 4:
                    System.out.print("Введите вторую дату, до которой следует осуществить поиск (XX.XX.XXXX): ");
                    String date2 = in.next();
                    
                    System.out.println("\nРезультаты поиска: ");
                    
                    if(mongocol.find(new Document("date", new Document("$gte", format.parse(date)).append("$lte", format.parse(date2)))).iterator().hasNext())
                        mongocol.find(new Document("date", new Document("$gte", format.parse(date)).append("$lte", format.parse(date2)))).forEach(block);
                    else
                        System.out.println("По данным критериям ничего не найдено");
                    break;
            }
        } catch (java.text.ParseException ex) {
            Logger.getLogger(DataBase.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
   
    public static void applicationDataBase(MongoCollection mongocol) {
        for(int i = 0; i < mongocol.count(); i++) {
            Document doc = (Document) mongocol.find(new Document("_id", i)).first();
            Object[] temp = doc.values().toArray();
            System.out.print((i + 1) + ". Заявитель: " + temp[1] + "; Услуга: " + 
                    temp[2] + "; Дата: " + format.format(temp[3]) + "\n");
        }
    }

    public static void fillDataBase(MongoCollection mongocol) { // Рандомное заполнение БД
        Document bdbo = new Document();
        Random random = new Random();
        bdbo.put("_id", (int) mongocol.count());
        switch(random.nextInt(7)) {
            case 0:
                bdbo.put("name", "Мария");
                break;
            case 1:
                bdbo.put("name", "Анастасия");
                break;
            case 2:
                bdbo.put("name", "Дмитрий");
                break;
            case 3:
                bdbo.put("name", "Олег");
                break;
            case 4:
                bdbo.put("name", "Александр");
                break;
            case 5:
                bdbo.put("name", "Вячеслав");
                break;
            case 6:
                bdbo.put("name", "Александра");
                break;
        }
        switch(random.nextInt(3)) {
            case 0:
                bdbo.put("service", "Получение паспорта гражданина РФ");
                break;
            case 1:
                bdbo.put("service", "Замена паспорта гражданина РФ");
                break;
            case 2:
                bdbo.put("service", "Выдача сертификата на материнский капитал");
                break;
        }
        try {
            switch(random.nextInt(7)) {
                case 0:
                    bdbo.put("date", format.parse("10.05.2017"));
                    break;
                case 1:
                    bdbo.put("date", format.parse("10.05.2017"));
                    break;
                case 2:
                    bdbo.put("date", format.parse("16.10.2016"));
                    break;
                case 3:
                    bdbo.put("date", format.parse("14.09.2015"));
                    break;
                case 4:
                    bdbo.put("date", format.parse("05.10.2017"));
                    break;
                case 5:
                    bdbo.put("date", format.parse("09.11.2016"));
                    break;
                case 6:
                    bdbo.put("date", format.parse("02.01.2017"));
                    break;
            }
        } catch (ParseException ex) {
            Logger.getLogger(DataBase.class.getName()).log(Level.SEVERE, null, ex);
        }
        mongocol.insertOne(bdbo);
    }
}


    
    