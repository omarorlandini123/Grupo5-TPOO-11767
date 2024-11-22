/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */
import java.util.List;

public class Curso {
    // Representa un curso impartido
    private String nombre; // Nombre del curso (por ejemplo, "Matemáticas")
    private List<Nota> notas; // Relación de composición: Las notas están vinculadas al curso

    // Constructor
    public Curso(String nombre, List<Nota> notas) {
        this.nombre = nombre;
        this.notas = notas;
    }

    // Getters y Setters
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public List<Nota> getNotas() {
        return notas;
    }

    public void setNotas(List<Nota> notas) {
        this.notas = notas;
    }
     // Para mostrar el nombre en el JComboBox
    @Override
    public String toString() {
        return nombre; // Esto es lo que se mostrará en el JComboBox
    }
}