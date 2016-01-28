package bogglehelper;

import java.io.IOException;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

/**
 *
 * @author MrSash
 */
public class BoggleHelper extends Application {
    
    private AnchorPane root;
    private Scene scene;
    
    @Override
    public void start(Stage stage) throws IOException {
        
        root = FXMLLoader.load(getClass().getResource("BoggleHelperInterface.fxml"));
        scene = new Scene(root);
        
        stage.setTitle("Boggle Helper");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
    
}
