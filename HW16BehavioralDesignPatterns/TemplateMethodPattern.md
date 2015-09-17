# Template Method Pattern



## Мотивация
Необходимост от дефиниране на структура на даден алгоритъм.

 
## Цел
* Дефинира структура на даден алгоритъм в метод, като се оставя част от имплементацията му на под-класовете.
* **Template Method pattern** позволява на подкласовете да предефинират имплементацията на дадена част/части от алгоритъма, но не им позволява да променят структурата на алгоритъма.
* Разчита на наследяване на класовете
* Обикновенно се овъррайдва виртуален или абстрактен метод наричан hook





## Приложение
Шаблонът се прилага обикновено, когато искаме да подпъхнем нова част в алгоритъма или да преизползваме неговите стъпки. Също така, когато искаме няколко класа(налседници) да изпозлват алгоритъм с една и съща структура, намиращ се в техният родителски клас. Начинът на работа и последователността на стъпките не се променят. някои от стъпките могат да бъдат напълно имплементирани в базовият клас, с цел да се спази принципа dont-repeat-yourself(DRY)

![](TemplateMethod1.jpg)

На клас диаграмата се вижда как подкласът ConcreteClass имплементира абстрактният метод subMethod().
 

## Известни употреби
В .NET може да се овъррайдва Render() метода.


## Имплементация

	public abstract class HotDrink {
	    public void PrepareRecipe()
	    {
	        BoilWater(); Brew(); PourInCup(); AddSpices();
	    }

	    protected abstract void Brew();
	    protected abstract void AddSpices();
	    private void BoilWater() { ... }
	    private void PourInCup() { ... }
	}

	public class Coffee : HotDrink {
	    protected override void Brew() { ... }
	    protected override void AddSpices() { ... }
	}

	public class Tea : HotDrink {
	    protected override void Brew() { ... }
	    protected override void AddSpices() { ... }
	}

В случая методите Brew и AddSpices ще бъдат имплементирани от под-класовете. BoilWater и PourInCup са имплементирани в базовият клас, защото имплементацията им е идентична за под-класовете.

## Сродни модели

**Template method** е близък до **Builder pattern**, с тази разлика, че **Builder pattern** в качеството си на creational pattern се грижи да създава инстанции на обекти, а **Template method** само пази структурата на алгоритъма.

