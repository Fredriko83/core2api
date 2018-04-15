import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.css']
})
export class BrandComponent implements OnInit {
  brands: any;

  constructor(private http: Http) {}

  ngOnInit() {
    this.getBrands();
  }

  getBrands() {
    this.http.get('http://localhost:5000/api/brands').subscribe(response => {
      this.brands = response.json();
    });
  }
}
