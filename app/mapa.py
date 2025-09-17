from datetime import datetime, timedelta

class Animal:
    def __init__(self, id, descripcion, fecha_registro, coordenadas, estado="Perdido"):
        self.id = id
        self.descripcion = descripcion
        self.fecha_registro = fecha_registro
        self.coordenadas = coordenadas
        self.estado = estado

    def actualizar_estado(self):
        if self.estado == "Perdido":
            dias_transcurridos = (datetime.now() - self.fecha_registro).days
            if dias_transcurridos >= 30:
                self.estado = "Adoptable"

# Ejemplo de uso
animal = Animal(
    id=1,
    descripcion="Perro mediano, pelaje marrón",
    fecha_registro=datetime(2025, 8, 10),
    coordenadas=(79.02, -8.11)
)

animal.actualizar_estado()
print(animal.estado)  # Adoptable si han pasado 30 días
import folium

# Crear un mapa centrado en Trujillo
mapa = folium.Map(location=[-8.115, -79.028], zoom_start=13)

# Agregar un marcador de prueba
folium.Marker(
    location=[-8.115, -79.028],
    popup="Ejemplo: Animal perdido aquí",
    icon=folium.Icon(color="red", icon="paw")
).add_to(mapa)

# Mostrar el mapa (en Jupyter)
mapa
mapa.save("mapa_animales_perdidos.html")
