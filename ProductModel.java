import javax.persistence.*;

@Entity
@Table(name = "Products")
public class Product {
    // create a constant MAX_PRICE and initialize it to 100000
    public static final BigDecimal MAX_PRICE = new BigDecimal("100000");

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "ProductID")
    private int productId;

    @Column(name = "ProductName")
    private String productName;

    @Column(name = "Price")
    private BigDecimal price;

    @ManyToOne
    @JoinColumn(name="CategoryID", nullable=false)
    private Category category;

    // Getters and setters
    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public BigDecimal getPrice() {
        return price;
    }

    public void setPrice(BigDecimal price) {
        // if the price exceeds the value of MAX_PRICE, throw an IllegalArgumentException
        if (price.compareTo(MAX_PRICE) > 0) {
            throw new IllegalArgumentException("Price exceeds the maximum value");
        }

        this.price = price;
    }

    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }
}