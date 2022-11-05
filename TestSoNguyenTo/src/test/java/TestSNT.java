import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Tag;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvFileSource;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.ValueSource;
/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author admin
 */
public class TestSNT {
    @Test
    public void testSoChan()
    {
        int n = 2;
        boolean expected = true;
        boolean actual = snt.ktNt(n);
        Assertions.assertEquals(expected, actual);
    }
    @Test
    @Tag("Critical")
    @DisplayName("KT NT Le")
    public void TestSoLe(){
        int n = 5;
        boolean actual = snt.ktNt(n);
        Assertions.assertTrue(actual);
    }
    
    @ParameterizedTest
    @ValueSource(ints = {2, 5, 7, 97, 103})
    public void testTrue(int n){
       Assertions.assertTrue(snt.ktNt(n), "Keith");
    }
    @ParameterizedTest
    @CsvSource({"1, false, chuoi1", "2, true, chuoi2", "4, false, chuoi3"})
    public void testAllValue(int n, boolean expected, String mess){
        boolean actual = snt.ktNt(n);
        Assertions.assertEquals(expected, actual, mess);
    }
    @ParameterizedTest
    @CsvFileSource(files="src/main/resource/data.csv", numLinesToSkip=0)
    public void testFile(int n, boolean expected, String mess){
        boolean actual = snt.ktNt(n);
        Assertions.assertEquals(expected, actual, mess);
    }
    @Test
    public void TestException(){
        int n = -3;
        Assertions.assertThrows(ArithmeticException.class, () -> {snt.ktNt(n);});
    }
}
