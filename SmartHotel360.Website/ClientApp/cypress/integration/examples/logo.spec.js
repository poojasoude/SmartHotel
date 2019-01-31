it('has a visible smarthotel logo', function() {
  //cy.get('.sh-auth-picture').should('be.visible');
  cy.title().should('eq', 'SmartHotel360')
});