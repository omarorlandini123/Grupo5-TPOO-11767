/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tc09;
import java.util.List;

/**
 * Clase que representa un grupo de estudiantes.
 * Un grupo puede tener varios estudiantes.4
 * Relación de Agregación entre Grupo y Estudiante
 */
public class Grupo {
    private String nombreGrupo;
    private List<Estudiante> estudiantes;

    // Constructor
    public Grupo(String nombreGrupo) {
        this.nombreGrupo = nombreGrupo;
    }

    // Getters y Setters
    public String getNombreGrupo() {
        return nombreGrupo;
    }

    public void setNombreGrupo(String nombreGrupo) {
        this.nombreGrupo = nombreGrupo;
    }

    public List<Estudiante> getEstudiantes() {
        return estudiantes;
    }

    public void setEstudiantes(List<Estudiante> estudiantes) {
        this.estudiantes = estudiantes;
    }
}
