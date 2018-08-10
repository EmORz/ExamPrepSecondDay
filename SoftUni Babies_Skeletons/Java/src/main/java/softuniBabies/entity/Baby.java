package softuniBabies.entity;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "babies")
public class Baby {
   // TODO
   @Id
   @GeneratedValue(strategy = GenerationType.IDENTITY)
   private Integer id;

    @Column
    @NotNull
    private String name;

    @Column
    @NotNull
    private String gender;

    @Column
    @NotNull
    private String	birthday ;

    public Baby() {
    }

    public Baby(String name, String gender, String birthday) {
        this.name = name;
        this.gender = gender;
        this.birthday = birthday;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }
}
