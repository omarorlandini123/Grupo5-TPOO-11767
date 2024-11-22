/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;
/**
 *
 * @author Acer
 */
public class Estudiante extends Persona {
    private String codigo; // Código único del estudiante
    private String grupo; // Grupo en formato "3er año B"

    // Constructor
    public Estudiante(String nombres, String apellidos, String codigo, String grupo) {
        super(nombres, apellidos); // Llama al constructor de Persona
        this.codigo = codigo;
        this.grupo = grupo;
    }

    // Getters y Setters
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getGrupo() {
        return grupo;
    }

    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }

    // Sobrescribir toString() para mostrar la información del estudiante de forma más legible
    @Override
    public String toString() {
        return getNombre() + " " + getApellido() + " - " + getCodigo() + " (" + getGrupo() + ")";
    }
}