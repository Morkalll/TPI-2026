classDiagram
    class Usuario {
        -Guid id
        -string nombre
        -string email
        -string passwordHash
        -RolUsuario rol
    }

    class Paciente {
        -string dni
        -Date fechaNacimiento
        -string telefono
        -string obraSocial
        +solicitarTurno() Turno
        +verTurnos() List
        +cancelarTurno(id: Guid) void
        +verHistorial() HistorialMedico
    }

    class Doctor {
        -string matricula
        -enum especialidad
        -List consultorios
        -bool disponible
        +verTurnos() List
        +solicitarCancelacion(id: Guid) void
        +verHistorialPaciente(id: Guid) HistorialMedico
    }

    class Recepcionista {
        -string legajo
        -string turnoLaboral
        -string sector
        +crearDoctor(data: Doctor) Doctor
        +eliminarDoctor(id: Guid) void
        +aprobarCancelacion(id: Guid) void
        +gestionarTurno(id: Guid) void
    }

    class Administrador {
        +crearUsuario(data) void
        +modificarUsuario(id: Guid) void
        +eliminarUsuario(id: Guid) void
        +verReportes(filtros) Reporte
    }

    class Consultorio {
        -Guid id
        -string numero
        -int piso
        -enum especialidad
    }

    class Turno {
        -Guid id
        -Guid pacienteId
        -Guid doctorId
        -Guid consultorioId
        -DateTime fechaHora
        -EstadoTurno estado
        +cambiarEstado(e: EstadoTurno) void
        +notificarCambio() void
        +esCancelable() bool
    }

    class HistorialMedico {
        -Guid id
        -Guid turnoId
        -string diagnostico
        -DateTime fechaTurno
        +obtenerResumen() string
        +agregarEntrada(diag: string) void
    }

    class EstadoTurno {
        <<enumeration>>
        PENDIENTE_APROBACION
        CONFIRMADO
        CANCELADO_PACIENTE
        CANCELADO_DOCTOR
    }

    Usuario <|-- Paciente
    Usuario <|-- Doctor
    Usuario <|-- Recepcionista
    Usuario <|-- Administrador

    Paciente "1" -- "0..N" Turno
    Doctor "1" -- "0..N" Turno
    Consultorio "1" -- "1..N" Turno
    Turno "1" -- "1" HistorialMedico
    Paciente "1" -- "1" HistorialMedico : tiene
