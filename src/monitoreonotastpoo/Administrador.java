/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */
public class Administrador extends Persona {
    // Relación de herencia: Administrador extiende Persona
    private String codigo; // Código único del administrador

    // Constructor
    public Administrador(String nombres, String apellidos, String codigo) {
        super(nombres, apellidos); // Llama al constructor de Persona
        this.codigo = codigo;
    }

    // Getters y Setters
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
}
