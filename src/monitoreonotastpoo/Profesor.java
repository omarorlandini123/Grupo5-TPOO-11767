/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */


public class Profesor extends Persona {
    private String codigo; // Código único del profesor
    private String curso; // Curso en el que enseña

    // Constructor
    public Profesor(String nombres, String apellidos, String codigo, String curso) {
        super(nombres, apellidos); // Llama al constructor de Persona
        this.codigo = codigo;
        this.curso = curso;
    }

    // Getters y Setters
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }

    @Override
    public String toString() {
        // Personaliza cómo se verá el profesor en el JList
        return getNombre() + " " + getApellido() + " (" + codigo + ")";
    }
}