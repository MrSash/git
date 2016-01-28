package bogglehelper;

import java.io.File;
import java.io.FileNotFoundException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.Scanner;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;

/**
 * FXML Controller class
 *
 * @author MrSash
 */
public class BoggleHelperInterfaceController implements Initializable {
    
    private char words[][];
    private String str = null;
    private Scanner scan;
    
    @FXML
    private TextField tfield11;
    @FXML
    private TextField tfield21;
    @FXML
    private TextField tfield31;
    @FXML
    private TextField tfield41;
    @FXML
    private TextField tfield51;
    @FXML
    private TextField tfield12;
    @FXML
    private TextField tfield22;
    @FXML
    private TextField tfield32;
    @FXML
    private TextField tfield42;
    @FXML
    private TextField tfield52;
    @FXML
    private TextField tfield13;
    @FXML
    private TextField tfield23;
    @FXML
    private TextField tfield33;
    @FXML
    private TextField tfield43;
    @FXML
    private TextField tfield53;
    @FXML
    private TextField tfield14;
    @FXML
    private TextField tfield24;
    @FXML
    private TextField tfield34;
    @FXML
    private TextField tfield44;
    @FXML
    private TextField tfield54;
    @FXML
    private TextField tfield15;
    @FXML
    private TextField tfield25;
    @FXML
    private TextField tfield35;
    @FXML
    private TextField tfield45;
    @FXML
    private TextField tfield55;
    @FXML
    private Button btnshow;
    @FXML
    private TextArea tarea;
    
    private int k = 0; 

    @FXML
    private void pressBtnShow(ActionEvent event) throws FileNotFoundException {
        words = new char[][]{
            {tfield11.getText().charAt(0), tfield12.getText().charAt(0), tfield13.getText().charAt(0), tfield14.getText().charAt(0), tfield15.getText().charAt(0)}, 
            {tfield21.getText().charAt(0), tfield22.getText().charAt(0), tfield23.getText().charAt(0), tfield24.getText().charAt(0), tfield25.getText().charAt(0)}, 
            {tfield31.getText().charAt(0), tfield32.getText().charAt(0), tfield33.getText().charAt(0), tfield34.getText().charAt(0), tfield35.getText().charAt(0)}, 
            {tfield41.getText().charAt(0), tfield42.getText().charAt(0), tfield43.getText().charAt(0), tfield44.getText().charAt(0), tfield45.getText().charAt(0)}, 
            {tfield51.getText().charAt(0), tfield52.getText().charAt(0), tfield53.getText().charAt(0), tfield54.getText().charAt(0), tfield55.getText().charAt(0)}
        };  
        
        int x1, x2, n;
        int[][] pos1;
        int[][] pos2;
        char c;
        String s = "";
        while(scan.hasNext()) {
            str = scan.next();
            pos1 = new int[str.length()][];
            pos2 = new int[str.length()][];
            for(int w = 0; w < str.length(); w++) {
                n = 0;
                for(int i = 0; i < 5; i++) {
                    for(int y = 0; y < 5; y++) {
                        if(words[i][y] == str.charAt(w)) {
                            pos1[w][n] = i;
                            pos2[w][n] = y;
                            n++;
                        }
                    }
                }
            }
            
            
            
        }
        scan.reset();
    }
    
    int Recursion() {
        
        return 1;
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        try {    
            scan = new Scanner(new File("Words.txt"), "cp1251");
        } catch (FileNotFoundException ex) {
            System.out.println("Файл не найден. Ошибка: " + ex);
        }
    }    
}
