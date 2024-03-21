namespace MyFirstMicroservice.Dtos;

public record class CardsDto(
  string Id,
  string Text,
  string Translate,
  int Level,
  string RepeatDate,
  DateOnly ReleaseDate);

