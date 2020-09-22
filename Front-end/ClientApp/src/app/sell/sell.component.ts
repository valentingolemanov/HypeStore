import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators, FormControl} from '@angular/forms';
import {Product} from './../models/Product';
import {ActivatedRoute} from '@angular/router';
import {Observable} from 'rxjs';
import {map, startWith} from 'rxjs/operators';

@Component({
  selector: 'app-sell',
  templateUrl: './sell.component.html',
  styleUrls: ['./sell.component.css']
})
export class SellComponent implements OnInit {

  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  isEditable = false;
  products: Array<Product>;
  productCtrl = new FormControl();
  filteredProducts: Observable<Product[]>;

  constructor(private _formBuilder: FormBuilder,
    private route: ActivatedRoute) {
      this.filteredProducts = this.productCtrl.valueChanges
      .pipe(
        startWith(''),
        map(product => product ? this._filterStates(product) : this.products.slice())
      );
    }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['']
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });

    this.route.data.subscribe(data => {
      this.products = data['prd_listing'];
    })

  }


  private _filterStates(value: string): Product[] {
    const filterValue = value.toLowerCase();

    return this.products.filter(product => product.Title.toLocaleLowerCase().includes(value.toLocaleLowerCase()));
  }


}
