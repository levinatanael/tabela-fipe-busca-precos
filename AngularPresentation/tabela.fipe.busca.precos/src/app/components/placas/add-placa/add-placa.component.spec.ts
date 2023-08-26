import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPlacaComponent } from './add-placa.component';

describe('AddPlacaComponent', () => {
  let component: AddPlacaComponent;
  let fixture: ComponentFixture<AddPlacaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddPlacaComponent]
    });
    fixture = TestBed.createComponent(AddPlacaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
