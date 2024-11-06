/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tc09;
import java.util.List;

/**
 * Clase que representa el boletín de un estudiante, que contiene todas sus calificaciones en un período específico.
 * Relación de Composición entre Estudiante y Boletin
 */
public class Boletin {
    private Estudiante estudiante;
    private List<Nota> notas;
    private String periodo;

    // Constructor
    public Boletin(Estudiante estudiante, String periodo) {
        this.estudiante = estudiante;
        this.periodo = periodo;
    }

    // Getters y Setters
    public Estudiante getEstudiante() {
        return estudiante;
    }

    public void setEstudiante(Estudiante estudiante) {
        this.estudiante = estudiante;
    }

    public List<Nota> getNotas() {
        return notas;
    }

    public void setNotas(List<Nota> notas) {
        this.notas = notas;
    }

    public String getPeriodo() {
        return periodo;
    }

    public void setPeriodo(String periodo) {
        this.periodo = periodo;
    }
}